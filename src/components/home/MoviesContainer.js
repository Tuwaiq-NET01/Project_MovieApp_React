import React, { Component } from "react";

import { connect } from "react-redux";

import Card from "./Card";

export class MoviesContainer extends Component {
  render() {
    const { movies } = this.props;
    console.log(movies);
    let content = "";

    // content =
    //   movies.Response === "True"
    //     ? movies.map((movie, index) => (
    //         // <Card key={index} movie={movie} name={movie.name} />
    //         <h1>{movie.name}</h1>
    //       ))
    //     : null;
    return (
      <div className="row">
        {movies.map((movie, index) => {
          return <Card key={index} movie={movie} />;
        })}
      </div>
    );
  }
}

const mapStateToProps = (state) => ({
  movies: state.movies.movies,
});

export default connect(mapStateToProps)(MoviesContainer);
