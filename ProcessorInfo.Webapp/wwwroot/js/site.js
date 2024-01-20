$(document).ready(function () {
    // Function to display the photo URL in a bigger format
    function displayPhotoInModal(photoUrl) {
        // Set the image source in the modal
        $("#modalPhoto").attr("src", photoUrl);

        // Open the modal
        $("#photoModal").modal("show");
    }

    // Attach click event to each image
    $(".card-img-top").click(function () {
        // Get the photo URL from the clicked image
        var photoUrl = $(this).attr("src");

        // Call the function to display the photo in a bigger format
        displayPhotoInModal(photoUrl);
    });
});
$(document).ready(function () {
    // Function to populate the details modal
    function populateModal(name, performanceCores, efficiencyCores, totalThreads, maxTurboFrequency, cache, integratedGraphics, chipset) {
        $('#modalProcessorName').text(name);
        console.log($('#modalProcessorName').text());

        $('#modalPerformanceCores').text(performanceCores);
        console.log($('#modalPerformanceCores').text());

        $('#modalEfficiencyCores').text(efficiencyCores);
        console.log($('#modalEfficiencyCores').text());

        $('#modalTotalThreads').text(totalThreads);
        console.log($('#modalTotalThreads').text());

        $('#modalMaxTurboFrequency').text(maxTurboFrequency);
        console.log($('#modalMaxTurboFrequency').text());

        $('#modalCache').text(cache);
        console.log($('#modalCache').text());

        $('#modalIntegratedGraphics').text(integratedGraphics);
        console.log($('#modalIntegratedGraphics').text());

        $('#modalChipset').text(chipset);
        console.log($('#modalChipset').text());

        // Open the details modal
        $('#processorModal').modal('show');
    }

    // Attach double-click event to each processor name
    $('.card-title').dblclick(function () {
        // Get processor details from the corresponding card
        var name = $(this).text();
        var performanceCores = $(this).siblings('.mb-2').find('.progress-bar.bg-success').attr('aria-valuenow');
        var efficiencyCores = $(this).siblings('.mb-2').find('.progress-bar.bg-info').attr('aria-valuenow');

        // Fetch additional data from the hidden div
        var totalThreads = $(this).siblings('.m-0').find('div:nth-child(1) p').text().trim();
        var maxTurboFrequency = $(this).siblings('.m-0').find('div:nth-child(2) p').text().trim();
        var cache = $(this).siblings('.m-0').find('div:nth-child(3) p').text().trim();
        var integratedGraphics = $(this).siblings('.m-0').find('div:nth-child(4) p').text().trim();
        var chipset = $(this).siblings('.m-0').find('div:nth-child(5) p').text().trim();

        // Call the function to populate and show the details modal
        populateModal(name, performanceCores, efficiencyCores, totalThreads, maxTurboFrequency, cache, integratedGraphics, chipset);
    });
});