<script lang="ts">
  import firebase from 'firebase/app';
  import 'firebase/auth';

  const auth = firebase.auth();

  // Firebase user
  export let user: { id: any; name: any; email: any; picture: any; token: any }|null = null;

  // expose property on the component that we can use
  // to choose if we want use popup or redirect
  export let useRedirect = false;

  // small mapper function
  const userMapper = (claims: { [x: string]: any; user_id?: any; name?: any; email?: any; picture?: any; token?: any }) => ({
    id: claims.user_id,
    name: claims.name,
    email: claims.email,
    picture: claims.picture,
    token: claims.token
  });

  export const loginWithEmailPassword = (email: string, password: string) =>
    auth.signInWithEmailAndPassword(email, password);

  export const loginWithGoogle = () => {
    const provider = new firebase.auth.GoogleAuthProvider();

    if (useRedirect) {
      return auth.signInWithRedirect(provider);
    } else {
      return auth.signInWithPopup(provider);
    }
  };

  export const loginWithFacebook = () => {
    const provider = new firebase.auth.FacebookAuthProvider();

    if (useRedirect) {
      return auth.signInWithRedirect(provider);
    } else {
      return auth.signInWithPopup(provider);
    }
  }

  export const logout = () => auth.signOut();

  // will be fired every time auth state changes
  auth.onAuthStateChanged(async fireUser => {
    if (fireUser) {
      // in here you might want to do some further actions
      // such as loading more data, etc.

      // if you want to set custom claims such as roles on a user
      // this is how to get them because they will be present
      // on the token.claims object
      const token = await fireUser.getIdTokenResult();
      user = userMapper(token.claims);
      user.token = token.token;
    } else {
      user = null;
    }
  });

  // reactive helper variable
  $: loggedIn = user !== null;
</script>

<!-- we will expose all required methods and properties on our slot -->
<div>
  <slot {user} {loggedIn} {loginWithGoogle} {loginWithEmailPassword} {loginWithFacebook} {logout} />
</div>