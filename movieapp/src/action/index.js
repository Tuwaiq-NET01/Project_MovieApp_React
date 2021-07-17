export const addTofavorites = (arg) => {
    return {
        type: "addTofavorites",
        payload: arg,
        
    }
}

export const removeFromFavorites = (arg,selectindex) => {
    return {
        type: "removeFromFavorites",
        payload: arg,
        index: selectindex
    }
}