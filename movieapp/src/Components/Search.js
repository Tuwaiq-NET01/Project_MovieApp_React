import React, { Component } from 'react'
import { Form, FormGroup, FormControl, ControlLabel, Button } from 'react-bootstrap'
import {movies} from '../Actions';
import { connect } from "react-redux";

class Search extends Component {
    constructor(props)
    {
        super(props);
        this.state = {
            query: ''
        }
    }
    search()
    {
        console.log("Movie ", this.state.query);
        let url = `https://api.themoviedb.org/3/search/movie?api_key=a630815c5ed2cf2dc041a53d65fa3f6d&language=en-US&page=1&include_adult=false&query=${this.state.query}`;
        fetch(url, {
            method: 'GET',
        }).then(response => response.json())
        .then((jsonObj) => {this.props.movies(jsonObj.result)});
    }
    render() {
        return (
            <div>
                <Form inline className="col-md-12 col-md-offset-4">
                    <FormGroup>
                        <ControlLabel> Search </ControlLabel>{" "}
                        <FormControl type="text" onChange={(event)=>this.setState({query:event.target.value})}></FormControl>{" "}
                        <Button bsStyle="success" onClick={()=>this.search()}> Submit </Button>
                    </FormGroup>
                </Form>
            </div>
        )
    }
}
export default connect(null, { movies })(Search);
