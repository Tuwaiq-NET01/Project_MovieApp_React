import React, { useEffect, useState } from "react";
import { Route } from "react-router-dom";
import Layout from "./components/Layout";
import Home from "./components/Home";

import "./custom.css";
import "./components/library/library.css";
import Login from "./components/auth/Login";
import Register from "./components/auth/Register";
import axios from "axios";
import Library from "./components/library/Library";
import Favorite from "./components/library/Favorites/Favorite";
import AddNew from "./components/library/AddPage/AddNew";
import Profile from "./components/auth/Profile";
import Search from "./components/library/SearchOutside/Search";
import Info from "./components/library/Info/Info";
import Edit from "./components/library/Edit/Edit";

import { useSelector, useDispatch } from "react-redux";
import { userAdded, movieAdded, movieInitialize } from "./action";

function App() {
  const [user, setUser] = useState({});
  const [id, setId] = useState(0);

  const userRedux = useSelector((state) => state.user);
  const favMovieList = useSelector((state) => state.favMoviesList);
  const dispatch = useDispatch();

  useEffect(() => {
    getUser();
    return () => {};
  }, []);

  const getUser = () => {
    axios
      .get("https://localhost:5001/api/auth/user", {
        withCredentials: true,
      })
      .then((res) => {
        console.log(res);
        setUser(res.data);
        dispatch(userAdded(res.data));
        console.log(res.data.profile.favoriteMovie);
        dispatch(movieInitialize(res.data.profile.favoriteMovie));
        console.log(userRedux);
      })
      .catch((err) => console.log(err));
  };

  return (
    <Layout user={user} setUser={setUser}>
      <Route exact path="/" component={() => <Home user={user} />} />
      <Route path="/login" component={() => <Login setUser={setUser} />} />
      <Route path="/register" component={Register} />
      <Route
        path="/profile"
        component={() => <Profile user={user} setUser={setUser} />}
      />
      <Route
        path="/movies"
        component={() => <Library user={user} setId={setId} which={1} />}
      />
      <Route
        path="/tv-shows"
        component={() => <Library user={user} setId={setId} which={2} />}
      />
      <Route
        path="/favorite-movies"
        component={() => <Favorite user={user} which={1} setId={setId} />}
      />
      <Route
        path="/favorite-tvshow"
        component={() => <Favorite user={user} which={2} setId={setId} />}
      />
      <Route
        path="/add-new-movie"
        component={() => <AddNew user={user} which={1} />}
      />
      <Route path="/edit-movie" component={() => <Edit which={1} id={id} />} />
      <Route
        path="/add-new-tvshow"
        component={() => <AddNew user={user} which={2} />}
      />
      <Route path="/edit-tvshow" component={() => <Edit which={2} id={id} />} />
      <Route
        path="/search-movie"
        component={() => <Search user={user} which={1} />}
      />
      <Route
        path="/search-tvshow"
        component={() => <Search user={user} which={2} />}
      />
      <Route path="/movie-info" component={() => <Info which={1} id={id} />} />
      <Route path="/tvshow-info" component={() => <Info which={2} id={id} />} />
      <footer className="footer">
        © 2021 IBRA's Movies Library. All rights reserved.
      </footer>
    </Layout>
  );
}
export default App;
