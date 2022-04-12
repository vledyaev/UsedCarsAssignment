import http from "../utils/http";

export const getCars = async () => {
    const result  = await http.get("Cars");

    return result?.data;
};

export const getWarehouseDetails = async (id: number) => {
    const result  = await http.get("Warehouses", { params:{ id: id }});

    return result?.data;
};