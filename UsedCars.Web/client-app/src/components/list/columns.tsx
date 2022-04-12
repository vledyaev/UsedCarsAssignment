import {GridColDef, GridValueFormatterParams, GridValueGetterParams} from "@mui/x-data-grid";

const formatDate = (value: string): string => {
    return (new Date(value)).toLocaleDateString();
}

const columns: GridColDef[] = [
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
    }
]

export default columns;