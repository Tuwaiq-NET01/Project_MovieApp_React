import React, { Component } from "react";
import {
  Form,
  FormControl,
  FormGroup,
  FormLabel,
  Button,
} from "react-bootstrap";
import { API_KEY } from "../secrets";
import { movies } from "../actions";
import { connect } from "react-redux";

class Search extends Component {
  constructor(props) {
    super(props);
    this.state = {
      query: "",
    };
  }

  search() {
    let url = `https://api.themoviedb.org/3/search/movie?api_key=${API_KEY}&language=en-US&page=1&include_adult=false&query=${this.state.query}`;
    fetch(url, {
      method: "GET",
    })
      .then((response) => response.json())
      .then((jsonObj) => {
        this.props.movies(jsonObj.results);
      });
  }

  render() {
    return (
      <div className="search">
        <Form inline >
          <FormGroup>
            <FormControl
              type="text"
              onChange={(event) => this.setState({ query: event.target.value })}
            />{" "}
            <Button bsStyle="success" onClick={() => this.search()}>
              Search
            </Button>
          </FormGroup>
        </Form>
      </div>
    );
  }
}

export default connect(null, { movies })(Search);
