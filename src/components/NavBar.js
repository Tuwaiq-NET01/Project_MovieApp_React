import React from 'react'
import { Navbar, Nav } from 'react-bootstrap'
import { Link } from 'react-router-dom'
import { useSelector, useDispatch } from 'react-redux'
import { useHistory } from 'react-router-dom'
import { logout } from '../actions'

export default function NavBar() {
  const user = JSON.parse(localStorage.getItem('user'))
  const isLoggedIn = useSelector((state) => state.login)
  const history = useHistory()
  const dispatch = useDispatch()

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
          />{' '}
          Mofie
        </Link>
      </Navbar.Brand>
      <Nav className="mr-auto">
        <Nav.Link as={Link} to="/">
          Home
        </Nav.Link>
      </Nav>
      <Navbar.Collapse className="justify-content-end">
        {isLoggedIn ? (
          <Navbar.Text>
            {' '}
            Logged in as: {user && user.name}
            <img
              onClick={() => {
                dispatch(logout())
                history.push('/login')
              }}
              src="https://img.icons8.com/office/80/000000/shutdown.png"
              width="30"
              height="30"
              style={{
                color: 'red',
                fontSize: '25px',
                marginLeft: '10px',
                cursor: 'pointer',
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
