import React, { useState } from "react"
import { Navbar, Nav } from "react-bootstrap"
import { BsToggleOn } from "react-icons/bs"
import { Link } from "react-router-dom"
import { useSelector, useDispatch } from "react-redux"
import { useHistory } from "react-router-dom"
import { logout, loggedIn } from "../actions"
import { useTranslation, Trans } from 'react-i18next'

export default function NavBar(props) {
 
  const isLoggedIn = useSelector((state) => state.login)
  const history = useHistory()
  const dispatch = useDispatch()
  const [IsArabic, setIsArabic] = useState(true)
 
  const user = JSON.parse(localStorage.getItem("user"))
  if (user) dispatch(loggedIn(true))

  return (
    <Navbar bg="dark" variant="dark">
      <Navbar.Brand>
        <Link to="/">
          <img
            alt="Logo"
            src="https://img.icons8.com/color/50/000000/starred-ticket.png"
            width="30"
            height="30"
            className="d-inline-block align-top"
          />{" "}
          Mofie
        </Link>
      </Navbar.Brand>
      <Nav className="mr-auto">
        <Nav.Link style={{ fontSize: "0.9rem" }} as={Link} to="/">

          <Trans i18nKey="HomePage">
          </Trans>

        </Nav.Link>
      </Nav>
      <Nav className="mr-auto">
        <Nav.Link style={{ fontSize: "0.9rem" }} as={Link} to="/search">

          <Trans i18nKey="SearchPage">
          </Trans>

        </Nav.Link>
      </Nav>
      <Nav className="mr-auto">
        <Nav.Link style={{ fontSize: "0.9rem" }} as={Link} to="/favorites">

        <Trans i18nKey="Favorites">
          </Trans>
          
        </Nav.Link>
      </Nav>
      <Navbar.Collapse className="justify-content-end">

        <button onClick={() => {
          setIsArabic(!IsArabic)
          const lang = IsArabic ? "en" : "ar"
          props.i18n.changeLanguage(lang)

        }} 
        style={{
          color: "#FFA726",
          fontSize: "1.0rem",
          marginRight: "10px",
          cursor: "pointer",
          borderRadius:"10px"
        }}
        >{IsArabic ? "English" : "Arabic"}</button>


        {isLoggedIn ? (
          <Navbar.Text style={{ fontSize: "0.9rem" }}>
            {" "}
            {user && user.name}
            <BsToggleOn
              style={{
                color: "#FFA726",
                fontSize: "1.2rem",
                marginLeft: "10px",
                cursor: "pointer",
              }}
              onClick={() => {
                dispatch(logout())
                history.push("/login")
              }}
            />
          </Navbar.Text>
        ) : (
          <Navbar.Text>
            <Link to="/login">Login</Link>
          </Navbar.Text>
        )}
      </Navbar.Collapse>
    </Navbar>
  )
}
