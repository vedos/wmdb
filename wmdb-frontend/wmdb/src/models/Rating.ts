import { Item } from "./Item";

export interface Rating {
    id: number;
    value: number;
    itemId: number;
    item: Item;
    userId: number;
    user: any;
}