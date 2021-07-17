export default function user(state = [], action) {
  switch (action.type) {
    case "userAdded":
      state = action.payload;
      return state;
    default:
      return state;
  }
}
