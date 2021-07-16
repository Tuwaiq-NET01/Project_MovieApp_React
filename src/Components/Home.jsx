import { Container, Row } from 'react-bootstrap';
import MovieCard from './MovieCard';
import React, { useState } from "react"
import Layout from "./Layout";
import ThemeContext from "./ThemeContext";

const Home = (props) => {
    const [theme, setTheme] = useState("light")
    const value = { theme, setTheme }
    const allmovies = props.topMovies.map((movie, i) => {
        return <MovieCard key={i} movie={movie} setSelectedMovie={props.setSelectedMovie} />
    })

    return (
        
        <ThemeContext.Provider value={value}>
        <Layout>
        <Container className="mb-5 mt-3">
            <Row className="justify-content-md-center">
                {allmovies}
            </Row>
        </Container>
        </Layout>
        </ThemeContext.Provider>

    );
}

export default Home;

