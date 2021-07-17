import React, { useContext } from "react"
import { Helmet } from "react-helmet"
import ThemeContext from "./ThemeContext"

const Layout = ({ children }) => {
  const { theme } = useContext(ThemeContext)
  const bg =
    theme == "dark"
      ? "body {background-color: gray; color: rgba(93, 23, 73,0.3);}"
      : "body {background-color: #fff; color: }"
  return (
    <>
      <Helmet>
        <style>{bg}</style>
      </Helmet>
      {children}
    </>
  )
}

export default Layout
