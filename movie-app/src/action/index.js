export const movieAdded = (arg) => {
    return {
        type: "movieAdded",
        payload: arg
    }
}

export const movieRemoved = (arg) => {
    return {
        type: "movieRemoved",
        payload: arg
    }
}