import React, { useState } from "react"
import { Container, Row, Col, Badge, Table, Button } from "react-bootstrap"
import { Link } from "react-router-dom"
import { useHistory } from "react-router"
import axios from "axios"

export default function SearchView() {
  const user = JSON.parse(localStorage.getItem("user"))
  const history = useHistory()
  if (!user) history.push("/login")

  const [keywords, setKeywords] = useState(() => "titanic")
  const [list, setList] = useState(() => [])

  const search = () => {
    axios(
      `https://api.themoviedb.org/3/search/movie?api_key=d7779d14a18e6ed420e482a36129e67b&language=en-US&query=${
        keywords.length > 1 ? keywords : "titanic"
      }&page=1`
    )
      .then((res) => {
        setList(res.data.results)
      })
      .catch((e) => {
        console.log(e.message)
      })
  }

  return (
    <Container fluid="md">
      <Row>
        <Col
          lg={12}
          style={{
            display: "flex",
            flexDirection: "column",
            justifyContent: "center",
            alignItems: "center",
            textAlign: "center",
          }}
        >
          <h1 style={{ color: "#FFA726", margin: "20px" }}>
            Search TMDB <Badge style={{ background: "black" }}>Anything</Badge>
          </h1>
          <input
            style={{
              width: "80%",
              borderWidth: 2,
              borderColor: "#FFA726",
              borderStyle: "double",
              borderRadius: "5px",
              padding: "10px",
            }}
            placeholder="titanic"
            type="text"
            value={keywords}
            onChange={(e) => {
              setKeywords(e.target.value)
              search()
            }}
          />
          <Table
            style={{
              width: "80%",
              margin: "20px",
              textAlign: "center",
            }}
            striped
            bordered
            hover
          >
            <thead>
              <tr>
                <th>Poster</th>
                <th>Title</th>
                <th>More</th>
              </tr>
            </thead>
            <tbody>
              {list.map((result, index) => {
                return (
                  <tr key={index}>
                    <td>
                      <img
                        src={
                          result.poster_path
                            ? `https://image.tmdb.org/t/p/w500/${result.poster_path}`
                            : "https://sd.keepcalms.com/i/keep-calm-poster-not-found.png"
                        }
                        width={84}
                        height={84}
                        alt={result.id}
                      />
                    </td>
                    <td>
                      <p style={{ marginTop: "20px" }}>
                        {result.original_title}
                      </p>
                    </td>
                    <td>
                      <Link to={`/movie/${result.id}`}>
                        <Button
                          style={{
                            background: "#FFA726",
                            color: "black",
                            borderWidth: "0px",
                            margin: "20px",
                          }}
                        >
                          Learn More
                        </Button>
                      </Link>
                    </td>
                  </tr>
                )
              })}
            </tbody>
          </Table>
        </Col>
      </Row>
    </Container>
  )
}
