<script lang="ts">
  import FiefManager from './fief-manager/fief-manager.svelte';
  import { buildingAlternatives } from '../stores/building-alternatives';
  import { postData } from '../api/api';

  async () => {
    postData({
      query:
        '{ buildingAlternatives { type upkeep stonework woodwork smithswork stone wood iron } }',
    })
      .then((res) => console.log(res))
      .catch((error) => console.log(error));
  };
</script>

<style>
  :global(*) {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
  }

  :global(.container) {
    display: flex;
    flex-direction: row;
  }

  :global(.column) {
    display: flex;
    flex-direction: column;
  }

  :global(.row) {
    display: flex;
    flex-direction: row;
  }
</style>

<div class="app">
  <FiefManager />
</div>
