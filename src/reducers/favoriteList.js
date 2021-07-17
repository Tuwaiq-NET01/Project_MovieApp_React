export default function favoriteList(state = [], action) {
    switch (action.type) {
        case "FAVORITE":
            return [
                ...state,
                action.payload
            ]
        case "REMOVEFAVORITE":
           state.splice(action.payload, 1)
            return [
                ...state
            ]
        
        default:
            return state
    }
}