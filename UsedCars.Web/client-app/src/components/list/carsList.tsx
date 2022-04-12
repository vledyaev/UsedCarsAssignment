import { useEffect, useState } from "react";
import {getCars, getWarehouseDetails} from "../../middleware/carsMiddleware";
import CircularProgress from '@mui/material/CircularProgress';
import {DataGrid, GridRowParams, GridSortingInitialState} from '@mui/x-data-grid';
import columns from './columns';
import CarDetails, { WarehouseDetails } from "../carDetails";

interface Car {
    make: string;
    id: number;
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
    const [cards, setCards] = useState<Car[]>([]);
    const [isCardDetailsOpened, setIsCardDetailsOpened] = useState<boolean>(false);
    const [carDetails, setCarDetails] = useState<WarehouseDetails|null>(null);

    useEffect(() => {
        (async () => {
            try {
                const cards = await getCars();
                setCards(cards);
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

    return (
        <>
            <div className="grid-container">
                <div className="grid">
                    <DataGrid
                        isRowSelectable={(params: GridRowParams) => params.row.licensed}
                        onRowClick={onRowClick}
                        initialState={{
                            sorting: sorting
                        }}
                        rows={cards}
                        columns={columns}
                        pagination
                        autoPageSize
                    />
                </div>
            </div>
            <CarDetails
                open={isCardDetailsOpened}
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