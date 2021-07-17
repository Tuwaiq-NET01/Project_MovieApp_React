export const increment = (arg) => {
  return {
    type: "INCREMENT", // this call reducers method
    payload: arg,
  };
};
export const decrement = () => {
  return {
    type: "DECREMENT", // this call reducers method
  };
};
export const movieInitialize = (arg) => {
  return {
    type: "movieInitialize",
    payload: arg,
  };
};
export const movieAdded = (arg) => {
  return {
    type: "movieAdded",
    payload: arg,
  };
};
export const movieDeleted = (arg) => {
  return {
    type: "contactDeleted",
    payload: arg,
  };
};

export const userAdded = (arg) => {
  return {
    type: "userAdded",
    payload: arg,
  };
};
