import React, { useContext } from "react"
import { Button } from "react-bootstrap"
import ThemeContext from "./ThemeContext"

function ThemeSwitcher() {
  const { theme, setTheme } = useContext(ThemeContext)

  return (
    <Button
      onClick={() => setTheme(theme == "dark" ? "light" : "dark")}
      className="button-theme"
    >
      <img
        src={theme == "dark" ? "https://static.thenounproject.com/png/4064526-200.png" : "https://static.thenounproject.com/png/1664849-200.png"}
        className="theme-icon"
        alt="theme"
        width="20"
      />
    </Button>
  )
}

export default ThemeSwitcher