import DialogTitle from "@mui/material/DialogTitle";
import List from "@mui/material/List";
import ListItem from "@mui/material/ListItem";
import ListItemText from '@mui/material/ListItemText';
import Dialog from "@mui/material/Dialog";
import ListItemIcon from '@mui/material/ListItemIcon';
import WarehouseIcon from '@mui/icons-material/Warehouse';
import LocationOnIcon from '@mui/icons-material/LocationOn';
import { Map, Marker } from "pigeon-maps";

export interface CarDetailsDialogProps {
    open: boolean;
    onClose: () => void;
    model: WarehouseDetails|null;
}

export interface WarehouseDetails {
    name: string,
    location: string,
    latitude: number,
    longitude: number
}

const CarDetails = (props: CarDetailsDialogProps) => {
    const { open, onClose, model } = props;
    const marker:[number, number] = model ? [model.latitude, model.longitude] : [0,0];

    return (
        <Dialog onClose={onClose} open={open} fullWidth maxWidth="sm">
            <DialogTitle>Car details</DialogTitle>
            <List>
                <ListItem>
                    <ListItemIcon>
                        <WarehouseIcon/>
                    </ListItemIcon>
                    <ListItemText primary={model?.name} />
                </ListItem>
                <ListItem>
                    <ListItemIcon>
                        <LocationOnIcon/>
                    </ListItemIcon>
                    <ListItemText primary={model?.location} />
                </ListItem>
            </List>
            <Map height={300} defaultCenter={marker} defaultZoom={7}>
                <Marker width={50} anchor={marker} />
            </Map>
        </Dialog>
    );
}

export default CarDetails;