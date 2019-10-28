$(() => {
	console.log(`Pupana`)
	$("#toggle-notes").click(function () {
		$('td:nth-child(5),th:nth-child(5)').toggle();
	});
	console.log(`Get outta dev tools!`)
});