import React, { Component } from 'react'
import FavoriteMovieList from './FavoriteMovieList'
import MovieResults from './MovieResults'
import { BrowserRouter as Router, Switch, Route } from 'react-router-dom'

export default class App extends Component {
  render() {
    return (
      <div className="container">
        <div className="row text-center">
        <div className="jumbotron">
          <h1>Movie Application!</h1>
          {/* <p>...</p>
          <p><a class="btn btn-primary btn-lg" href="#" role="button">Learn more</a></p> */}
       </div>
       </div>
       <div className="row">
         <Router>
           <Switch>
             <Route exact path='/' component={MovieResults} />
             <Route exact path='/fav' component={FavoriteMovieList} />
           </Switch>
         </Router>
       </div>
      </div>
    )
  }
}
