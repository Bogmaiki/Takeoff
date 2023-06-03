import { Box, Typography } from "@mui/material";
import Slider from "react-slick";

export default function HomePage() {
  const settings = {
    dots: true,
    infinite: true,
    speed: 500,
    slidesToShow: 1,
    slidesToScroll: 1,
    autoplaySpeed: 3000,
    autoplay: true
  };

  return (
    <Box maxWidth="100%" overflow="hidden">
      <Box display="flex" justifyContent="center" sx={{ p: 4 }}>
        <Typography variant="h1">
          Welcome to Takeoff Kicks!
        </Typography>
      </Box>
      <Slider {...settings}>
        <div>
          <img src="/images/Untitled_design_22.jpg" alt="image1" style={{ display: 'block', width: '100%', maxHeight: 900 }} />
        </div>
        <div>
          <img src="/images/WhatsApp_Image_2022-12-31_at_17.16.40.jpg" alt="image2" style={{ display: 'block', width: '100%', maxHeight: 900 }} />
        </div>
        <div>
          <img src="/images/FullSizeRender_1.jpg" alt="image3" style={{ display: 'block', width: '100%', maxHeight: 900 }} />
        </div>
      </Slider>
    </Box>
  );
}
