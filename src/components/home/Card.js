import React from "react";
import { NavLink } from "react-router-dom";

const Card = ({ movie }) => {
  return (
    <div className="col-md-3 mb-5">
      <div className="card card-body bg-dark text-center h-100">
        <img
          className="w-100 mb-2"
          src={`https://image.tmdb.org/t/p/original${movie.poster_path}`}
          alt="Movie Cover"
        />
        <h5 className="text-light card-title">
          <NavLink to={`/movie/${movie.id}`}>{movie.name}</NavLink>
        </h5>
      </div>
    </div>
  );
};

export default Card;
