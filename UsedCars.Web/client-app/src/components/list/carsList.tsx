import { useEffect, useState } from "react";
import {getCars} from "../../middleware/carsMiddleware";
import CircularProgress from '@mui/material/CircularProgress';
import { DataGrid, GridSortingInitialState } from '@mui/x-data-grid';
import columns from './columns';

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

const CarsList = (): JSX.Element => {
    const [isLoading, setIsLoading] = useState<boolean>(true);
    const [cards, setCards] = useState<Car[]>([]);

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

    return (
        <>
            <div className="grid-container">
                <div className="grid">
                    <DataGrid
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

            { isLoading &&
                <div className="loader-wrapper">
                    <CircularProgress sx={{

                    }} />
                </div>  }
        </>
    )
}

export default CarsList;