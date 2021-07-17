export const increment = (amount) => {
  return {
    type: "INCREMENT",
    payload: amount,
  };
};
export const decrement = () => {
  return {
    type: "DECREMENT",
  };
};

export const login = (user) => {
  return {
    type: "LOGIN",
    payload: user,
  };
};

export const loggedIn = (status) => {
  return {
    type: "LOGGEDIN",
    payload: status,
  };
};

export const logout = () => {
  return {
    type: "LOGOUT",
  };
};

export const AddFav = (movie) => {
  return {
    type: "ADD_FAV",
    payload: movie,
  };
};
export const DeleteFav = (movie) => {
  return {
    type: "DELETE_FAV",
    payload: movie,
  };
};
