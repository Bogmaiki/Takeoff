import { Send, SentimentSatisfiedAlt } from "@mui/icons-material";
import { LoadingButton } from "@mui/lab";
import { Box, Container, Paper, TextField, Typography } from "@mui/material";
import { FieldValues, useForm } from "react-hook-form";
import { useLocation, useNavigate } from "react-router-dom";

export default function ContactPage() {
    const navigate = useNavigate();
    const location = useLocation();
    const { handleSubmit, formState: { isSubmitting, isValid } } = useForm({
        mode: 'onTouched'
    });

    async function submitForm(data: FieldValues) {
        try {
            navigate(location.state?.from || '/catalog');
        } catch (error) {
            console.log(error);
        }
    }
    
    return (
        <>
            <Typography variant='h1'>
                Contact Us
            </Typography>
            <Typography variant='h5'>
                Do you have any questions for us?
                Talk to us on our Instagram page, @takeoff_kicks
                We will answer you every question you have  {<SentimentSatisfiedAlt/>} 
                Or leave us a message here 
            </Typography>
            <Container component={Paper} 
                sx={{ display: 'flex', flexDirection: 'column', alignItems: 'center', p: 4, mt:5 }}>
                <Box component="form" onSubmit={handleSubmit(submitForm)} noValidate sx={{ mt: 1 }}>
                    <TextField
                        margin="normal"
                        fullWidth
                        label="Name"
                        autoFocus
                    />
                    <TextField
                        margin="normal"
                        required
                        fullWidth
                        label="Email"
                        type="email"
                    />
                    <TextField
                        margin="normal"
                        fullWidth
                        label="Phone Number"
                        type="phone"
                    />
                    <TextField
                        margin="normal"
                        required
                        fullWidth
                        label="Comment"
                        type="text"
                    />
                    <LoadingButton
                        disabled={!isValid}
                        loading={isSubmitting}
                        type="submit"
                        fullWidth
                        variant="contained"
                        sx={{ mt: 3, mb: 2 }}
                    >
                        Submit {<Send/>}
                    </LoadingButton>
                </Box>
            </Container>
        </>
    )
}
