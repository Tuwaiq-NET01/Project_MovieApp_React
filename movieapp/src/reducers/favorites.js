const favorites = (state = [], action) => {
    switch (action.type) {
        case "addTofavorites": // this called from the action
            // return state + 1
           console.log(state)
            return [
                ...state,
                action.payload
            ]
        case "removeFromFavorites":
            let arrCopy = [...state]
            console.log(action.index)
            arrCopy.forEach((movie,index) => {
                if (index === action.index){
                    arrCopy.splice(action.index, 1)
                }
            });
            return arrCopy
        default:
            return state;
    }
};
export default favorites;