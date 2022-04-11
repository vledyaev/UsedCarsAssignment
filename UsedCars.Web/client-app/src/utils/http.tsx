import axios from "axios";

const axiosInstance = axios.create({
    headers: {
        Pragma: 'no-cache',
        'Content-Type': 'application/json',
    }
});

export default axiosInstance;