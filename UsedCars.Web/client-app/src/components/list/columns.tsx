import {
    GridRowParams,
    GridValueFormatterParams,
    GridValueGetterParams,
    GridActionsCellItem
} from "@mui/x-data-grid";
import AddIcon from '@mui/icons-material/Add';
import RemoveIcon from '@mui/icons-material/Remove';
import * as React from "react";

const formatDate = (value: string): string => {
    return (new Date(value)).toLocaleDateString();
}

const getColumns = (onAdd: (id: number) => void, onRemove: (id: number) => void) => [
    {field: 'licensed', headerName: 'Licensed', width: 100, type: 'boolean'},
    {field: 'make', headerName: 'Make', flex: 1},
    {field: 'model', headerName: 'Model', flex: 1},
    {field: 'year', headerName: 'Year', flex: 1, type: 'date'},
    {field: 'price', headerName: 'Price $', flex: 1, type: 'number'},
    {
        field: 'dateAdded',
        headerName: 'Date Added',
        flex: 1,
        type: 'date',
        valueFormatter: (params: GridValueFormatterParams) => {
            return formatDate(params.value);
        },
        valueGetter: (params: GridValueGetterParams) => {
            return (new Date(params.value)).getTime();
        }
    },
    {
        field: 'actions',
        type: 'actions',
        getActions: (params: GridRowParams) => [
            <>
                {
                    params.row.licensed && (
                        params.row.selected ? (
                            <GridActionsCellItem icon={<RemoveIcon />} label="Remove" onClick={() => onRemove(params.row.id)} />
                        ) : (
                            <GridActionsCellItem icon={<AddIcon />} label="Add" onClick={() => onAdd(params.row.id)} />
                        )
                    )
                }
            </>
        ]
    }
];

export default getColumns;