
export interface Item {
    id: number;
    title: string;
    description: string;
    category?: any;
    categoryId: number;
    thumbnail: string;
    releaseDate: Date;
    casts: any[];
    rating: number;    
    current_rating: number;
}