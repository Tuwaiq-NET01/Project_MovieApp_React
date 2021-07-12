import React from 'react'
import { useHistory } from 'react-router'

export default function HomeView() {
  const user = JSON.parse(localStorage.getItem('user'))
  const history = useHistory()
  if (!user) history.push('/login')
  return <div>Home</div>
}
