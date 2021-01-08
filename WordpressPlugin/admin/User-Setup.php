<?php
/**
* Show custom user profile fields
* Add Time Login in Customer Login page.
* @param  object $profileuser A WP_User object
* @return void
*/

function CadNativeTest47_user_profile_fields( $profileuser ) {
    ?>
<table class='form-table'>
    
<tr >
		<th scope="row"><?php _e( 'Time logging' ); ?></th>
		<td>
			<label for="CadNativeTest47_Tracker"><input name="CadNativeTest47_Tracker" type="checkbox" id="CadNativeTest47_Tracker" value="false" <?php checked( 'false', $profileuser->CadNativeTest47_Tracker ); ?> />
				<?php _e( 'Enable time loging for this user' ); ?>
			</label>
		</td>
	</tr>
</table>
<?php
}

function CadNativeTest47_save_extra_user_profile_fields( $user_id ) {
    if ( !current_user_can( 'edit_user', $user_id ) ) {
        return false;
    }
    update_user_meta( $user_id, 'CadNativeTest47_Tracker', $_POST['CadNativeTest47_Tracker'] );
}

add_action( 'show_user_profile', 'CadNativeTest47_user_profile_fields' );
add_action( 'edit_user_profile', 'CadNativeTest47_user_profile_fields' );
add_action( "user_new_form", "CadNativeTest47_user_profile_fields" );

add_action('user_register', 'CadNativeTest47_save_extra_user_profile_fields');
add_action('profile_update', 'CadNativeTest47_save_extra_user_profile_fields');