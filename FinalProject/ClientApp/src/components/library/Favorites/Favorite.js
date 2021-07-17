import React, { useEffect, useState } from "react";
import { useSelector, useDispatch } from "react-redux";
import { movieAdded } from "../../../action";
import axios from "axios";
import { useHistory } from "react-router-dom";

function Favorite(props) {
  const [favList, setFavList] = useState([]);
  const [user, setUser] = useState({});
  const [loading, setLoading] = useState(true);

  const favMovieList = useSelector((state) => state.favMoviesList);
  const dispatch = useDispatch();

  useEffect(() => {
    console.log("redux", favMovieList);
    getList();
    getProfile();
    return () => {};
  }, []);

  const history = useHistory();

  const getList = () => {
    if (props.which == 1) {
      axios
        .get("https://localhost:5001/api/FavoriteMovies", {
          withCredentials: true,
        })
        .then((res) => {
          setLoading(false);
          console.log(res.data);
          setFavList(res.data);
          //   dispatch(movieAdded(res.data));
          console.log("redux", favMovieList);
        })
        .catch((err) => console.log(err));
    } else if (props.which == 2) {
      axios
        .get("https://localhost:5001/api/favoritetvshows", {
          withCredentials: true,
        })
        .then((res) => {
          setLoading(false);
          console.log(res.data);
          setFavList(res.data);
        })
        .catch((err) => console.log(err));
    }
  };

  const getProfile = () => {
    axios
      .get("https://localhost:5001/api/auth/user", {
        withCredentials: true,
      })
      .then((res) => {
        console.log(res);
        setUser(res.data);
      })
      .catch((err) => console.log(err));
  };

  const deleteFromFav = (id) => {
    if (props.which == 1) {
      axios
        .delete(`https://localhost:5001/api/favoritemovies/${id}`, {
          withCredentials: true,
        })
        .then((res) => {
          console.log(res);
          getList();
          getProfile();
        })
        .catch((err) => console.log(err));
    } else if (props.which == 2) {
      axios
        .delete(`https://localhost:5001/api/favoritetvshows/${id}`, {
          withCredentials: true,
        })
        .then((res) => {
          console.log(res);
          getList();
          getProfile();
        })
        .catch((err) => console.log(err));
    }
  };

  const info = (id) => {
    props.setId(id);
    if (props.which == 1) {
      history.push(`/movie-info/${id}`, { id: id });
    } else if (props.which == 2) {
      history.push(`/tvshow-info/${id}`, { id: id });
    }
  };

  let whichList;
  let header;
  if (props.which == 1) {
    header = "Favorite Movies";
    whichList =
      user.profile && user.profile.favoriteMovie
        ? favList.map((favMovie, index) => (
            <div className="col " key={index}>
              <div className="card hoverMe" style={{ borderRadius: "30px" }}>
                <img
                  src={favMovie.movie.poster}
                  className="card-img-top"
                  alt="..."
                  style={{ borderRadius: "30px 30px 0px 0px" }}
                  onClick={() => info(favMovie.movie.id)}
                />
                <div className="card-body">
                  <h5
                    className="card-title"
                    style={{ paddingBottom: "20px" }}
                    onClick={() => info(favMovie.movie.id)}
                  >
                    {favMovie.movie.title}
                  </h5>
                  <div className="card-text" style={{ textAlign: "right" }}>
                    <i
                      className="fas fa-trash-alt fa-2x myActionBtn"
                      onClick={() => deleteFromFav(favMovie.movie.id)}
                    ></i>
                  </div>
                </div>
              </div>
            </div>
          ))
        : null;
  } else if (props.which == 2) {
    header = "Favorite TV Shows";
    whichList =
      user.profile && user.profile.favoriteTvShow
        ? favList.map((favTvShow, index) => (
            <div className="col " key={index}>
              <div className="card hoverMe" style={{ borderRadius: "30px" }}>
                <img
                  src={favTvShow.tvShow.poster}
                  className="card-img-top"
                  alt="..."
                  style={{ borderRadius: "30px 30px 0px 0px" }}
                  onClick={() => info(favTvShow.tvShow.id)}
                />
                <div className="card-body">
                  <h5
                    className="card-title"
                    style={{ paddingBottom: "20px" }}
                    onClick={() => info(favTvShow.tvShow.id)}
                  >
                    {favTvShow.tvShow.title}
                  </h5>
                  <div className="card-text" style={{ textAlign: "right" }}>
                    <i
                      className="fas fa-trash-alt fa-2x myActionBtn"
                      onClick={() => deleteFromFav(favTvShow.tvShow.id)}
                    ></i>
                  </div>
                </div>
              </div>
            </div>
          ))
        : null;
  }

  const renderFavTable = () => {
    return (
      <div className="row row-cols-1 row-cols-md-4 g-4 fade-me">
        {whichList}
      </div>
    );
  };

  let contents = loading ? (
    <p>
      <em>Loading...</em>
    </p>
  ) : (
    renderFavTable()
  );

  return (
    <div className="fade-me">
      <h1 id="tabelLabel" style={{ textAlign: "center", marginBottom: "60px" }}>
        {header}
      </h1>
      {contents}
    </div>
  );
}

export default Favorite;
