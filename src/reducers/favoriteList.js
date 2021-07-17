export default function favoriteList(state = [], action) {
    switch (action.type) {
        case "FAVORITE":
            return [
                ...state
            ]
        case "REMOVEFAVORITE":
           
            return [
                ...state
            ]
        
        default:
            return state
    }
}