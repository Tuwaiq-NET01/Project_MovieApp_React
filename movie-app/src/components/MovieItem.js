import React, { Component } from "react";
import { addToFavorite, removeFromFavorite } from "../actions";
import { connect } from "react-redux";
import Popup from 'reactjs-popup';
import 'reactjs-popup/dist/index.css';
import FavoriteMovieList from "./FavoriteMovieList";
import { useTranslation, Trans } from 'react-i18next'


const urlComponent = "https://image.tmdb.org/t/p/w342";
const movieUrl = "https://www.themoviedb.org/movie/";

class MovieItem extends Component {
  constructor(props) {
    super(props);

    this.state = {
      favorited: false,
    };
  }

  addToFavorite() {
    this.setState({ favorited: !this.state.favorited });
    this.props.addToFavorite(this.props.movie);
  }

  removeFromFavorite() {
    this.setState({ favorited: !this.state.favorited });
    this.props.removeFromFavorite(this.props.movie);
  }

  displayFav() {
    if (!this.state.favorited) {
      return (
        <span
          className="glyphicon glyphicon-heart-empty"
          onClick={() => this.addToFavorite()}
        ></span>
      );
    } else {
      return (
        <span
          className="glyphicon glyphicon-heart"
          onClick={() => this.removeFromFavorite()}
        ></span>
      );
    }
  }
  render() {
    return (
      <div className="col-md-3 offset-md-3">
      <div className="card">
        <div className="thumbnail">
          <a href={movieUrl + this.props.movie.id} target="_blank">
            <img
              src={urlComponent + this.props.movie.poster_path}
              alt={this.props.movie.title + " Image"}
            />
          </a>
            <h4>{this.props.movie.title}</h4>
            <Popup trigger={<button className="btn btn-outline-success" style={{color:"green"}}> Overview</button>} position="right center">
            <p style={{color:"green"}}>{this.props.movie.overview}</p>

           </Popup>
           <p> {this.props.movie.genres}</p>
            <p>Release Date - {this.props.movie.release_date}</p>
            <p>
              Ratings -{" "}
              <span className="badge badge-default">
                <span
                  className="glyphicon glyphicon-star"
                  aria-hidden="true"
                ></span>{" "}
                {this.props.movie.vote_average}
              </span>
            </p>
            <p>{this.props.showButton ? this.displayFav() : null}</p>
          </div>
        </div>
        </div>
      
    );
  }
}

export default connect(null, { addToFavorite, removeFromFavorite })(MovieItem);
