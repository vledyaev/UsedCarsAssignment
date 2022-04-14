import {MouseEventHandler, useEffect, useState} from "react";
import {getCars, getWarehouseDetails} from "../../middleware/carsMiddleware";
import CircularProgress from '@mui/material/CircularProgress';
import {DataGrid, GridRowParams, GridSortingInitialState} from '@mui/x-data-grid';
import getColumns from './columns';
import CarDetails, { WarehouseDetails } from "../carDetails";
import ShoppingCard from "../shoppingCard";

export interface Car {
    make: string;
    model: string;
    id: number;
    selected: boolean;
    price: number;
}

const sorting: GridSortingInitialState = {
    sortModel: [
        {
            field: 'dateAdded',
            sort: 'desc'
        }
    ]
}

const CarsList = () => {
    const [isLoading, setIsLoading] = useState<boolean>(true);
    const [cars, setCars] = useState<Car[]>([]);
    const [isCarDetailsOpened, setIsCardDetailsOpened] = useState<boolean>(false);
    const [carDetails, setCarDetails] = useState<WarehouseDetails|null>(null);

    const onAddToShoppingList = (id: number) => {
        setCars(cars.map(x => {
            if (x.id !== id) {
                return x;
            }

            x.selected = true;
            return x;
        }))
    }

    const onRemoveFromShoppingList = (id: number) => {
        setCars(cars.map(x => {
            if (x.id !== id) {
                return x;
            }

            x.selected = false;
            return x;
        }))
    }

    const columns = getColumns(onAddToShoppingList, onRemoveFromShoppingList);

    useEffect(() => {
        (async () => {
            try {
                const cars = await getCars();
                setCars(cars);
                setIsLoading(false);
            }
            catch {
                console.log('error')
            }
        })()
    }, [])

    const onRowClick = (params: GridRowParams):void => {
        if (params.row.licensed) {
            setIsLoading(true);
            (async () => {
                try {
                    const warehouse = await getWarehouseDetails(params.row.warehouseId);
                    setCarDetails(warehouse);
                    setIsCardDetailsOpened(true);
                    setIsLoading(false);
                }
                catch {
                    console.log('error')
                }
            })()
        }
    }

    const clearBucket = () => {
        setCars(cars.map(x => {
            x.selected = false;
            return x;
        }))
    }

    return (
        <>
            <ShoppingCard cars={cars} onClear={clearBucket} onDelete={onRemoveFromShoppingList}/>
            <div className="grid-container">
                <div className="grid">
                    <DataGrid
                        isRowSelectable={(params: GridRowParams) => params.row.licensed}
                        onRowClick={onRowClick}
                        initialState={{
                            sorting: sorting
                        }}
                        rows={cars}
                        columns={columns}
                        pagination
                        autoPageSize
                    />
                </div>
            </div>
            <CarDetails
                open={isCarDetailsOpened}
                onClose={() => setIsCardDetailsOpened(false)}
                model={carDetails}
            />
            { isLoading &&
                <div className="loader-wrapper">
                    <CircularProgress />
                </div>  }
        </>
    )
}

export default CarsList;