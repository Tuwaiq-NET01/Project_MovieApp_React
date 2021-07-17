import React, { Component } from "react";
import { connect } from "react-redux";
import { Link } from "react-router-dom";

import { fetchMovie, setLoading } from "../../actions/searchActions";

import Spinner from "../layout/Spinner";

export class Movie extends Component {
  componentDidMount() {
    this.props.fetchMovie(this.props.match.params.id);
    this.props.setLoading();
  }
  render() {
    const { movie } = this.props;
    return (
      <div className="container">
        <div className="row">
          <div className="col-md-4 card card-body">
            <img
              src={`https://image.tmdb.org/t/p/original${movie.poster_path}`}
              className="thumbnail"
              alt="Poster"
            />
          </div>
          <div className="col-md-8">
            <h2 className="mb-4">{movie.title}</h2>
            <ul className="list-group">
              <li className="list-group-item">
                <strong>Overview:</strong> {movie.overview}
              </li>
              <li className="list-group-item">
                <strong>Released:</strong> {movie.release_date}
              </li>
              <li className="list-group-item">
                <strong>Rated:</strong> {movie.vote_average}
              </li>
              <li className="list-group-item">
                <strong>IMDB Rating:</strong> {movie.popularity}
              </li>
            </ul>
          </div>
        </div>
        <div className="row">
          <div className="card card-body bg-dark my-5 text-light">
            <div className="col-md-12">
              <h3>Plot </h3>
              {movie.tagline}
              <hr />
              <a
                href={"https://www.imdb.com/title/" + movie.imdb_id}
                target="_blank"
                rel="noopener noreferrer"
                className="btn btn-primary"
              >
                View on IMDB
              </a>
            </div>
          </div>
        </div>
      </div>
    );
  }
}

const mapStateToProps = (state) => ({
  loading: state.movies.loading,
  movie: state.movies.movie,
});

export default connect(
  mapStateToProps,
  { fetchMovie, setLoading }
)(Movie);
