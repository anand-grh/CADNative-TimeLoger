<?php 

  function add_time_log ( $params ){
 
        
    $parameter=$params->get_params();

    if ( isset( $parameter['AppVersion'] ) && isset( $parameter['UserKey'] )  && isset( $parameter['curShot'] ) ){

        global $table_prefix, $wpdb;

        $tblname = 'timeloger47';
        $tablename=$table_prefix . "$tblname";

        $data=array(
            'AppVersion' => $parameter['AppVersion'], 
            'UserKey' => $parameter['UserKey'],
            'curShot' => date ('Y-m-d H:i:s', $parameter['curShot']), 
            'keyStrokeCount' => $parameter['keyStrokeCount'],
            'mouseClickCount' => $parameter['mouseClickCount'], 
            'lastCaptureImage' => $parameter['lastCaptureImage']
           );
    
         $result = $wpdb->insert( $tablename, $data);

         
         if($result=== false){
            return 0;
         }

         return $result;
        
        
    }

      return 0;
  }

  // Register the rest route here.

  add_action( 'rest_api_init', function () {
       
       register_rest_route( 'CNT47/v1', 'upload',array(

           'methods'  => 'POST',
           'callback' => 'add_time_log'

       ) );

} );