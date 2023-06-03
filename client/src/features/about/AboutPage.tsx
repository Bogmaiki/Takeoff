import { Box, Typography } from "@mui/material";

export default function AboutPage() {

    return (
        <>
            <Box display="flex" justifyContent="center" alignContent='center' sx={{ p: 5 }}>
                <Typography variant='h4'>
                    Who are Takeoff Kicks?
                </Typography>
            </Box>
            <Typography variant='body1'>
                Takeoff Kicks is an authentic reseller of aftermarket sneakers located in Ashkelon, Israel.
                We have more than 2 years of experience in the sneaker reseller market with hundreds of deals all over the world.
                We offer express shipping for all our Israeli customers and a pick-up option from Ashkelon.
            </Typography>
            <div>
                <img src="/images/Untitled_design_22.jpg" alt="image1" style={{ display: 'block', width: '100%', maxHeight: 900, marginTop: 20 }} />
            </div>
        </>
    )
}