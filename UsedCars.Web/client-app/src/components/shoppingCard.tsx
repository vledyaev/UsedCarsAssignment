import {Car} from "./list/carsList";
import ShoppingCartIcon from '@mui/icons-material/ShoppingCart';
import {Chip, IconButton, Popover, Table, TableBody, TableCell, TableRow} from "@mui/material";
import {useEffect, useRef, useState} from "react";
import DeleteIcon from '@mui/icons-material/Delete';

interface ShoppingCardPreviewProps {
    cars: Car[],
    onDelete: (id: number) => void,
    onClear: () => void
}

const ShoppingCard = (props: ShoppingCardPreviewProps) => {
    const { cars, onDelete, onClear } = props;
    const [isCardOpened, setIsCardOpened] = useState<boolean>(false);
    const popoverAnchor = useRef<HTMLDivElement>(null);

    const selectedCars = cars.filter(x => x.selected);

    const cardInfo = selectedCars.reduce((x, item) => {
        x.total += item.price;
        x.number++;

        return x;
    }, { total: 0, number: 0});

    const showCard = () => {
        if (selectedCars.length > 0) {
            setIsCardOpened(true);
        }
    }

    useEffect(() => {
        if(selectedCars.length === 0 && isCardOpened) {
            setIsCardOpened(false);
        }
    }, [selectedCars, isCardOpened]);

    return (
        <>
            <div className="shopping-card-preview">
                <Chip
                    ref={popoverAnchor}
                    avatar={<ShoppingCartIcon />}
                    label={`Selected items: (${cardInfo.number}) Total: ${cardInfo.total}$`}
                    onDelete={onClear}
                    onClick={showCard}
                />
            </div>
            <Popover
                open={isCardOpened}
                onClose={() => setIsCardOpened(false)}
                anchorEl={popoverAnchor.current}
                anchorOrigin={{
                    vertical: 'bottom',
                    horizontal: 'left',
                }}
            >
                <Table>
                    <TableBody>
                        {
                            selectedCars.map(car => (
                                <TableRow
                                    key={car.id}
                                >
                                    <TableCell>{car.model} {car.make}</TableCell>
                                    <TableCell>{car.price}$</TableCell>
                                    <TableCell>
                                        <IconButton onClick={() => onDelete(car.id)}>
                                            <DeleteIcon/>
                                        </IconButton>
                                    </TableCell>
                                </TableRow>
                            ))
                        }
                    </TableBody>
                </Table>
            </Popover>
        </>
    )
}

export default ShoppingCard;