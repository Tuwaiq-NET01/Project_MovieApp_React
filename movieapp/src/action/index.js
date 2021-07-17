export const addTofavorites = (arg) => {
    return {
        type: "addTofavorites",
        payload: arg,
        
    }
}

export const removeFromFavorites = (arg,i) => {
    return {
        type: "removeFromFavorites",
        payload: arg,
        index:i
      
    }
}