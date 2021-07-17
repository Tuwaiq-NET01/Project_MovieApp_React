export const addFavorite = (arg) => {
    return {
        type: 'FAVORITE', // this call reducers method
        payload: arg,
    };
};