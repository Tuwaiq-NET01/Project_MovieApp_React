import React, { useState, useEffect } from 'react'
import { Link, BrowserRouter as Router , Switch, Route} from "react-router-dom";
import Detail from './Detail';
import Favorite from "./Favorite";
import Homepage from "./Homepage";
import Search from "./Search";

export default function Navbar() {
    
    const [searchRes, setSearchRes] = useState('')


  return (
    <>
      <Router>

          
      <nav class="navbar navbar-expand-lg navbar-light bg-light">
  <div class="container-fluid">
    <a class="navbar-brand ms-5" href="#">MovieApp</a>

    <div class="collapse navbar-collapse" id="navbarSupportedContent">
      <ul class="navbar-nav me-auto mb-2 mb-lg-0">
        <li class="nav-item">
          <Link to="/" className="nav-link" aria-current="page">All Movies</Link>

        </li>
        <li class="nav-item">
          <Link to="/favorites" className="nav-link">Favorites</Link>
        </li>
      </ul>
      <form class="d-flex">
        <input class="form-control me-3" type="search" placeholder="Search" aria-label="Search"  onChange={(e) => setSearchRes(e.target.value)}/>
        
        
        <Link className="me-5" to="/search">
                    <button
                      class="btn btn-secondary"
                      type="submit"
                    >
                      Search
                    </button>
                  </Link>

                  
      </form>
    </div>
  </div>
</nav>
    
    <Switch>
        <Route
              exact
              path="/"
              render={() => <Homepage />}
            />

              
<Route
              exact
              path="/favorites"
              render={() => <Favorite />}
            />

    <Route
              exact
              path="/search"
              render={() => <Search target={searchRes} />}
            />

<Route
              exact
              path="/movies/:id"
              render={() => <Detail />}
            />


    </Switch>



      </Router>
    </>
  );
}
