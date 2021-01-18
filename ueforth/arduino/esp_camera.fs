( Handling for ESP32-CAM )

0 constant PIXFORMAT_RGB565
1 constant PIXFORMAT_YUV422
2 constant PIXFORMAT_GRAYSCALE
3 constant PIXFORMAT_JPEG
4 constant PIXFORMAT_RGB888
5 constant PIXFORMAT_RAW
6 constant PIXFORMAT_RGB444
7 constant PIXFORMAT_RGB555

5 constant FRAMESIZE_QVGA
8 constant FRAMESIZE_VGA

( See https://github.com/espressif/esp32-camera/blob/master/driver/include/esp_camera.h )
( Settings for AI_THINKER )
create camera-config
  32 , ( pin_pwdn ) -1 , ( pin_reset ) 0 , ( pin_xclk )
  26 , ( pin_sscb_sda ) 27 , ( pin_sscb_scl )
  35 , 34 , 39 , 36 , 21 , 19 , 18 , 5 , ( pin_d7 - pin_d0 )
  25 , ( pin_vsync ) 23 , ( pin_href ) 22 , ( pin_pclk )
  20000000 , ( xclk_freq_hz )
  0 , ( ledc_timer ) 0 , ( ledc_channel )
  here
  PIXFORMAT_RGB565 , ( pixel_format )
  FRAMESIZE_VGA , ( frame_size ) 12 , ( jpeg_quality 0-63 low good )
  here
  1 , ( fb_count )
constant camera-fb-count
constant camera-format
