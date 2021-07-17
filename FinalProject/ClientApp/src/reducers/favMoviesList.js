export default function favMoviesList(state = [], action) {
  switch (action.type) {
    case "movieInitialize":
      state = action.payload;
      return state;
    case "movieAdded":
      return [...state, action.payload];
    case "movieDeleted":
      state.splice(action.payload.index, 1);
      return [...state];
    default:
      return state;
  }
}
