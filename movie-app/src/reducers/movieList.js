export default function movieList(state = [], action) {
    switch (action.type) {
        case "movieAdded":
            return [
                ...state, 
                {
                    movie: action.payload.movie
                }
            ]

        case "movieRemoved" :
            state.splice(action.payload.index, 1)
            return [
                ...state
            ]
        default:
            return state
    }
}