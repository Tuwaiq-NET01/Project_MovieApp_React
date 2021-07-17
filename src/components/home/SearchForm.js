import React, { Component } from "react";
import { useTranslation, Trans } from "react-i18next";
import { connect } from "react-redux";

import {
  searchMovie,
  fetchMovies,
  setLoading,
} from "../../actions/searchActions";

const langs = {
  en: "English",
  ar: "Arabic",
};

export class SearchForm extends Component {
  onChange = (e) => {
    this.props.searchMovie(e.target.value);
  };

  onSubmit = (e) => {
    e.preventDefault();
    this.props.fetchMovies(this.props.text);
    this.props.setLoading();
  };

  render() {
    return (
      <div className=" mt-5 text-center">
        <div className="container">
          <h1 className="display-4 mb-3">Search ..</h1>
          <form id="searchForm" onSubmit={this.onSubmit} className="mb-5">
            <input
              type="text"
              className="form-control"
              name="searchText"
              onChange={this.onChange}
            />
            <button type="submit" className="btn btn-info btn-bg mt-3">
              Search
            </button>
          </form>
        </div>
      </div>
    );
  }
}

const mapStateToProps = (state) => ({
  text: state.movies.text,
});

export default connect(
  mapStateToProps,
  { searchMovie, fetchMovies, setLoading }
)(SearchForm);
