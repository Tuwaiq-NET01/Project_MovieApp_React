const favorite = (state = [], action) => {
  switch (action.type) {
    case "ADD_FAV":
      return [...state, action.payload];
    case "DELETE_FAV":
      return state.map((item, index) => {
        if (item.id === action.payload.id) {
          return action.payload;
        }
        return item;
      });
    default:
      return state;
  }
};
export default counter;
