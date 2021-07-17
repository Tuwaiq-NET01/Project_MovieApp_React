export const addFavorite = (arg) => {
    return {
        type: 'FAVORITE',
        payload: arg
    };
};