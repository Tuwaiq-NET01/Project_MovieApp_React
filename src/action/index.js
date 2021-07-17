export const addFavorite = (arg) => {
    return {
        type: 'FAVORITE',
        payload: arg
    };
};

export const removeFavorite = (arg) => {
    return {
        type: 'REMOVEFAVORITE',
        payload: arg
    }
}