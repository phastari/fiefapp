<script lang="ts">
  import { getGamesessions } from '../../api/gamesessions/get-gamesessions';
  import { addGamesession } from '../../api/gamesessions/add-gamesession';
  import type { Gamesession } from '../../models/gamesession';
  import GamesessionComponent from './components/gamesession-component.svelte';
  import { userStore } from '../../stores/authentication';
  import { onMount } from 'svelte';

  let gamesessions: Gamesession[] = [];
  let response: Gamesession[] = [];

  const get = async () => {
    response =  await getGamesessions($userStore == null ? $userStore?.id : null);
  }

  const add = async () => {
    response.push(await addGamesession($userStore == null ? $userStore?.id : null));
  }

  onMount(() => {
    get();
  })

  $: gamesessions = response;
</script>

<style>

</style>

<h1>GAMESESSIONS</h1>
{#each gamesessions as gamesession, i}
  <GamesessionComponent 
    id={gamesession.id}
    name={gamesession.name}
    coloredBackground={i % 2 == 1}
  />
{/each}
<button on:click={() => add()}>lägg till</button>