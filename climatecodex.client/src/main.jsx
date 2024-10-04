import { createRoot } from 'react-dom/client'
import AppRouter from './routes/AppRouter'
import './index.scss'
import "./styles/global.scss"
createRoot(document.getElementById('root')).render(
  <AppRouter />
)
