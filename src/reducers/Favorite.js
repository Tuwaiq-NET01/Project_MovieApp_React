const favorite = (state = [], action) => {
  switch (action.type) {
    case "ADD_FAV":
      return [...state, action.payload];
    case "DELETE_FAV":
      return state.filter((x) => x.id !== action.payload.id);
    default:
      return state;
  }
};
export default favorite;
