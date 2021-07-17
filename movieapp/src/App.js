import PopularMovie from './components/PopularMovie';
import SearchMoive from './components/SearchMoive';
import Home from './components/Home';
import { BrowserRouter as Router, Route } from "react-router-dom";
import 'bootstrap/dist/css/bootstrap.min.css';
function App() {
  return (
    <div className="App">
       <Router>

        <Route exact path="/">
         <Home/>
        </Route>
       
        <Route exact path="/popular">
          <PopularMovie/>
        </Route>

        <Route exact path="/search">
          <SearchMoive />
        </Route>

      </Router>
    </div>
  );
}

export default App;
