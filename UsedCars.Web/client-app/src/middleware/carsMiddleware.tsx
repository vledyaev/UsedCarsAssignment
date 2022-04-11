import React from "react";
import http from "../utils/http";

export const getCars = async () => {
    const result  = await http.get("Cars");

    return result?.data;
};