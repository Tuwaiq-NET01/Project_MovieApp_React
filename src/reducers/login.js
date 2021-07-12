const login = (state = false, action) => {
  switch (action.type) {
    case 'LOGIN':
      localStorage.setItem('user', JSON.stringify(action.payload))
      return true
    case 'LOGOUT':
      localStorage.setItem('user', null)
      return false
    default:
      return state
  }
}
export default login
