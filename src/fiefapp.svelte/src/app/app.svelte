<script lang="ts">
  import firebase from 'firebase/app';
  import { fade } from 'svelte/transition';
  import Router from 'svelte-spa-router';
  import Authentication from './authentication/authentication.svelte';
  import FiefManager from './fief-manager/fief-manager.svelte';
  import Gamesessions from './gamesessions/gamesessions.svelte';
  import Home from './home/home.svelte';

  const firebaseConfig = {
    apiKey: 'AIzaSyCz2GeGRuj1g818rSQ5aykjFe4cXH2wQCw',
    authDomain: 'fiefapp-35d5e.firebaseapp.com',
    projectId: 'fiefapp-35d5e'
  };

  firebase.initializeApp(firebaseConfig);

  let loginWithEmailPassword: any;
  let error: Error | null = null;

  const loginHandler = async (event: Event) => {
    const email = ((event.target as HTMLFormElement).elements).namedItem("email") as RadioNodeList;
    const password = ((event.target as HTMLFormElement).elements).namedItem("password") as RadioNodeList;

    try {
      error = null;
      await loginWithEmailPassword(email.value, password.value);
    } catch (err) {
      error = err;
    }
  };

  const routes = {
    '/': Home,
    '/fiefmanager': FiefManager,
    '/gamesessions': Gamesessions
  }
</script>

<div>
  <Authentication
    useRedirect={false}
    let:user
    let:loggedIn
    let:loginWithGoogle
    let:loginWithFacebook
    bind:loginWithEmailPassword
    let:logout
  >
    {#if loggedIn}
      <div>
        <h2>
          {#if user}
            {user.email}
            {user.token}
          {/if}
        </h2>
        <button type="button" on:click={logout}>Logout</button>
      </div>
    {:else}
      <div>
        <form
          on:submit|preventDefault={loginHandler}
        >
          <div>
            <label for="email">Email</label>
            <input
              class="input-field"
              id="email"
              type="email"
              placeholder="name@acme.com"
            />
          </div>
          <div>
            <label for="password">Password</label>
            <input
              class="input-field"
              id="password"
              type="password"
              placeholder="******************"
            />
          </div>
          {#if error}
            <div transition:fade>{error.message}</div>
          {/if}
          <div>
            <button type="submit">Sign In</button>
          </div>
          <div>
            <button type="button" on:click|preventDefault={loginWithGoogle}>
              Sign in with Google
            </button>
            <button type="button" on:click|preventDefault={loginWithFacebook}>
              Sign in with Facebook
            </button>
          </div>
        </form>
      </div>
    {/if}
  </Authentication>
  <Router {routes}/>
</div>