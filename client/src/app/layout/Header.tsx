import { ShoppingCart } from "@mui/icons-material";
import { AppBar, Avatar, Badge, Box, Container, FormControlLabel, IconButton, Menu, MenuItem, Switch, Toolbar, Tooltip, Typography, styled } from "@mui/material";
import { Link, NavLink } from "react-router-dom";
import logoImage from "../../Logo.png";
import { useAppSelector } from "../store/configureStore";
import SignedInMenu from "./SignedInMenu";
import { useState } from "react";
import MenuIcon from '@mui/icons-material/Menu';

const midLinks = [
    { title: 'home', path: '/' },
    { title: 'catalog', path: '/catalog' },
    { title: 'about', path: '/about' },
    { title: 'contact', path: '/contact' },
]
const rightLinks = [
    { title: 'login', path: '/login' },
    { title: 'register', path: '/register' },
]

const MaterialUISwitch = styled(Switch)(({ theme }) => ({
    width: 62,
    height: 34,
    padding: 7,
    '& .MuiSwitch-switchBase': {
        margin: 1,
        padding: 0,
        transform: 'translateX(6px)',
        '&.Mui-checked': {
            color: '#fff',
            transform: 'translateX(22px)',
            '& .MuiSwitch-thumb:before': {
                backgroundImage: `url('data:image/svg+xml;utf8,<svg xmlns="http://www.w3.org/2000/svg" height="20" width="20" viewBox="0 0 20 20"><path fill="${encodeURIComponent(
                    '#fff',
                )}" d="M4.2 2.5l-.7 1.8-1.8.7 1.8.7.7 1.8.6-1.8L6.7 5l-1.9-.7-.6-1.8zm15 8.3a6.7 6.7 0 11-6.6-6.6 5.8 5.8 0 006.6 6.6z"/></svg>')`,
            },
            '& + .MuiSwitch-track': {
                opacity: 1,
                backgroundColor: theme.palette.mode === 'dark' ? '#8796A5' : '#aab4be',
            },
        },
    },
    '& .MuiSwitch-thumb': {
        backgroundColor: theme.palette.mode === 'dark' ? '#003892' : '#001e3c',
        width: 32,
        height: 32,
        '&:before': {
            content: "''",
            position: 'absolute',
            width: '100%',
            height: '100%',
            left: 0,
            top: 0,
            backgroundRepeat: 'no-repeat',
            backgroundPosition: 'center',
            backgroundImage: `url('data:image/svg+xml;utf8,<svg xmlns="http://www.w3.org/2000/svg" height="20" width="20" viewBox="0 0 20 20"><path fill="${encodeURIComponent(
                '#fff',
            )}" d="M9.305 1.667V3.75h1.389V1.667h-1.39zm-4.707 1.95l-.982.982L5.09 6.072l.982-.982-1.473-1.473zm10.802 0L13.927 5.09l.982.982 1.473-1.473-.982-.982zM10 5.139a4.872 4.872 0 00-4.862 4.86A4.872 4.872 0 0010 14.862 4.872 4.872 0 0014.86 10 4.872 4.872 0 0010 5.139zm0 1.389A3.462 3.462 0 0113.471 10a3.462 3.462 0 01-3.473 3.472A3.462 3.462 0 016.527 10 3.462 3.462 0 0110 6.528zM1.665 9.305v1.39h2.083v-1.39H1.666zm14.583 0v1.39h2.084v-1.39h-2.084zM5.09 13.928L3.616 15.4l.982.982 1.473-1.473-.982-.982zm9.82 0l-.982.982 1.473 1.473.982-.982-1.473-1.473zM9.305 16.25v2.083h1.389V16.25h-1.39z"/></svg>')`,
        },
    },
    '& .MuiSwitch-track': {
        opacity: 1,
        backgroundColor: theme.palette.mode === 'dark' ? '#8796A5' : '#aab4be',
        borderRadius: 20 / 2,
    },
}));

interface Props {
    darkMode: boolean;
    handleThemeChange: () => void;
}
export default function Header({ darkMode, handleThemeChange }: Props) {
    const { cart } = useAppSelector(state => state.cart);
    const { user } = useAppSelector(state => state.account);
    const itemCount = cart?.items.reduce((sum, item) => sum + item.quantity, 0)
    const [anchorElNav, setAnchorElNav] = useState<null | HTMLElement>(null);
    const [anchorElUser, setAnchorElUser] = useState<null | HTMLElement>(null);

    const handleOpenNavMenu = (event: React.MouseEvent<HTMLElement>) => {
        setAnchorElNav(event.currentTarget);
    };
    const handleOpenUserMenu = (event: React.MouseEvent<HTMLElement>) => {
        setAnchorElUser(event.currentTarget);
    };

    const handleCloseNavMenu = () => {
        setAnchorElNav(null);
    };

    const handleCloseUserMenu = () => {
        setAnchorElUser(null);
    };

    return (
        <AppBar position="static" >
            <Container maxWidth="xl" >
                <Toolbar disableGutters >
                    <IconButton
                        size="large"
                        aria-label="account of current user"
                        aria-controls="menu-appbar"
                        aria-haspopup="true"
                        onClick={handleOpenNavMenu}
                        color="inherit"
                        edge="start"
                    >
                        <MenuIcon />
                    </IconButton>
                    <Typography variant="h6" component={NavLink}
                        to='/'
                        sx={{ display: { xs: 'none', md: 'flex' }, mr: 1 }}
                    >
                        <img src={logoImage} alt="Takeoff Kicks" width='100' height='auto' />
                    </Typography>
                    <Box sx={{ flexGrow: 1 }} />
                    <FormControlLabel
                        checked={darkMode}
                        onChange={handleThemeChange}
                        control={<MaterialUISwitch sx={{ m: 1 }} defaultChecked />} label={undefined} />
                    <Box
                        sx={{
                            display: { xs: 'block', md: 'none' },
                            position: 'absolute',
                            top: '100%',
                            left: 0,
                            width: '100%',
                            bgcolor: 'background.paper',
                            mt: 2,
                            zIndex: 1,
                            boxShadow: 2,
                        }}
                    >
                        <Menu
                            id="menu-appbar"
                            anchorEl={anchorElNav}
                            anchorOrigin={{
                                vertical: 'top',
                                horizontal: 'left',
                            }}
                            keepMounted
                            transformOrigin={{
                                vertical: 'top',
                                horizontal: 'left',
                            }}
                            open={Boolean(anchorElNav)}
                            onClose={handleCloseNavMenu}
                        >
                            {midLinks.map(({ title, path }) => (
                                <MenuItem component={NavLink} to={path} key={path} onClick={handleCloseNavMenu}>
                                    <Typography textAlign="center">{title.toUpperCase()}</Typography>
                                </MenuItem>
                            ))}
                            {user && user.roles?.includes('Admin') &&
                            <MenuItem component={NavLink} to={'/inventory'} onClick={handleCloseNavMenu}>
                                <Typography textAlign="center">INVENTORY</Typography>
                            </MenuItem>}
                        </Menu>
                    </Box>
                    <Box sx={{ flexGrow: 0, display: 'flex', alignItems: 'center' }}>
                        <IconButton component={Link} to='/cart' edge='start' color='inherit' sx={{ display: 'flex', alignItems: 'center', mr: 3 }}>
                            <Badge badgeContent={itemCount} color='secondary'>
                                <ShoppingCart />
                            </Badge>
                        </IconButton>
                        {user ? (
                            <SignedInMenu />
                        ) : (
                            <Box sx={{ flexGrow: 0 }}>
                                <Tooltip title={undefined}>
                                    <IconButton onClick={handleOpenUserMenu} sx={{ p: 0 }}>
                                        <Avatar />
                                    </IconButton>
                                </Tooltip>
                                <Menu
                                    sx={{ mt: '45px' }}
                                    id="menu-appbar"
                                    anchorEl={anchorElUser}
                                    anchorOrigin={{
                                        vertical: 'top',
                                        horizontal: 'right',
                                    }}
                                    keepMounted
                                    transformOrigin={{
                                        vertical: 'top',
                                        horizontal: 'right',
                                    }}
                                    open={Boolean(anchorElUser)}
                                    onClose={handleCloseUserMenu}
                                >
                                    {rightLinks.map(({ title, path }) => (
                                        <MenuItem component={NavLink} to={path} key={path} onClick={handleCloseUserMenu}>
                                            <Typography textAlign="center">{title.toUpperCase()}</Typography>
                                        </MenuItem>
                                    ))}
                                </Menu>
                            </Box>
                        )}
                    </Box>
                </Toolbar>
            </Container >
        </AppBar>
    );
}
